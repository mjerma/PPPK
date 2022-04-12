/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.dao;

import hr.algebra.model.Vozac;
import hr.algebra.model.Vozilo;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.List;
import javax.sql.DataSource;

/**
 *
 * @author Mihael
 */
public class SqlHandler {

    private static final String INSERT_VOZILA = 
            "INSERT INTO Vozilo (Tip, Marka, GodinaProizvodnje, PrijedeniKilometri, JeSlobodno) VALUES (?, ?, ?, ?, ?)";
    
    private static final String INSERT_VOZACI = 
            "INSERT INTO Vozac (Ime, Prezime, BrojMobitela, BrojVozackeDozvole) VALUES (?, ?, ?, ?)";
    
    public static void insertVozila(List<Vozilo> vozila, int chunkSize) {
        DataSource dataSource = DataSourceSingleton.getInstance();
        try (Connection con = dataSource.getConnection();
                PreparedStatement stmt = con.prepareStatement(INSERT_VOZILA)){

            int counter = 0;
            for (Vozilo vozilo : vozila) {
                stmt.setString(1, vozilo.getTip());
                stmt.setString(2, vozilo.getMarka());
                stmt.setInt(3, vozilo.getGodinaProizvodnje());
                stmt.setInt(4, vozilo.getPrijedeniKilometri());
                stmt.setBoolean(5, vozilo.getJeSlobodno());
                stmt.addBatch();
                if (++counter == chunkSize) {
                    stmt.executeBatch();
                    System.out.println("checkpoint: " + counter);
                    counter = 0;
                }
            }
            if (counter > 0) {
                stmt.executeBatch();
                System.out.println("checkpoint: " + counter);
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    
    public static void insertVozaci(List<Vozac> vozaci, int chunkSize) {
        DataSource dataSource = DataSourceSingleton.getInstance();
        try (Connection con = dataSource.getConnection();
                PreparedStatement stmt = con.prepareStatement(INSERT_VOZACI)){

            int counter = 0;
            for (Vozac vozac : vozaci) {
                stmt.setString(1, vozac.getIme());
                stmt.setString(2, vozac.getPrezime());
                stmt.setString(3, vozac.getBrojMobitela());
                stmt.setString(4, vozac.getBrojVozackeDozvole());
                stmt.addBatch();
                if (++counter == chunkSize) {
                    stmt.executeBatch();
                    System.out.println("checkpoint: " + counter);
                    counter = 0;
                }
            }
            if (counter > 0) {
                stmt.executeBatch();
                System.out.println("checkpoint: " + counter);
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    
}
