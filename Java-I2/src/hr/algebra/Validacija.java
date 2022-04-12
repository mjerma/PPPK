/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra;

import hr.algebra.dao.DataSourceSingleton;
import hr.algebra.model.Vozilo;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;
import javax.sql.DataSource;

/**
 *
 * @author Mihael
 */
public class Validacija {
    
    private static final String SELECT_VOZILA = "SELECT * FROM Vozilo";
    private static final String ADD_VOZILO = "INSERT INTO Vozilo (Tip, Marka, GodinaProizvodnje, PrijedeniKilometri, JeSlobodno) VALUES (?, ?, ?, ?, ?)";
    private static final String UPDATE_PRIJEDENI_KILOMETRI = "UPDATE Vozilo SET PrijedeniKilometri=? WHERE IDVozilo = ?";
    private static final String DELETE_VOZILO = "DELETE FROM Vozilo WHERE IDVozilo = ?";
    
    public static void main(String[] args) {
        performWork();
    }

    private static void performWork() {
        DataSource dataSource = DataSourceSingleton.getInstance();

        try (Connection con = dataSource.getConnection()) {
            con.setAutoCommit(false);
            System.out.println("Current:");
            List<Vozilo> vozila = getVozila(con);
            printVozila(vozila);
            List<Vozilo> novaVozila = createVozila();
            try (PreparedStatement addVoziloStatement = con.prepareStatement(ADD_VOZILO, Statement.RETURN_GENERATED_KEYS);
                    PreparedStatement updatePrijedeniKilometriStatement = con.prepareStatement(UPDATE_PRIJEDENI_KILOMETRI);
                    PreparedStatement deleteVoziloStatement = con.prepareStatement(DELETE_VOZILO)) {

                List<Integer> kreiranaVozilaIds = addVozila(addVoziloStatement, novaVozila);
                
                updatePrijedeniKilometri(updatePrijedeniKilometriStatement, kreiranaVozilaIds, 10);
                deleteVozilo(deleteVoziloStatement, kreiranaVozilaIds.get(kreiranaVozilaIds.size() - 1));
            }

            System.out.println("Not commited:");
            printVozila(getVozila(con));

            if (acceptChanges()) {
                con.commit();
                System.out.println("Changes commited");
            } else {
                con.rollback();
                System.out.println("Changes rollbacked");

            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    
    private static List<Vozilo> getVozila(Connection con) throws SQLException {
        List<Vozilo> list = new ArrayList<>();
        try (Statement stmt = con.createStatement();
                ResultSet resultSet = stmt.executeQuery(SELECT_VOZILA)) {
            while (resultSet.next()) {
                list.add(new Vozilo(
                        resultSet.getInt(1),
                        resultSet.getString(2),
                        resultSet.getString(3),
                        resultSet.getInt(4),
                        resultSet.getInt(5),
                        resultSet.getBoolean(6)));
            }
        }
        return list;
    }

    private static void printVozila(List<Vozilo> vozila) {
        vozila.forEach(System.out::println);
    }

    private static List<Vozilo> createVozila() {
        List<Vozilo> list = new ArrayList<>();
        for (int i = 0; i < 5; i++) {
            list.add(new Vozilo(generateString(6), generateString(6), getRandomNumber(1950,2020), getRandomNumber(1, 300000), true));
        }
        return list;
    }

    private static List<Integer> addVozila(PreparedStatement addVoziloStatement, List<Vozilo> vozila) throws SQLException {
        List<Integer> list = new ArrayList<>();
        
        for (Vozilo vozilo : vozila) {
            addVoziloStatement.setString(1, vozilo.getTip());
            addVoziloStatement.setString(2, vozilo.getMarka());
            addVoziloStatement.setInt(3, vozilo.getGodinaProizvodnje());
            addVoziloStatement.setInt(4, vozilo.getPrijedeniKilometri());
            addVoziloStatement.setBoolean(5, vozilo.getJeSlobodno());
            addVoziloStatement.execute();

            ResultSet generatedKeys = addVoziloStatement.getGeneratedKeys();
            if (generatedKeys != null && generatedKeys.next()) {
                list.add(generatedKeys.getInt(1));
            }
        }
        return list;
    }

    private static void updatePrijedeniKilometri(PreparedStatement updatePrijedeniKilometriStatement, List<Integer> kreiranaVozilaIds, int prijedeniKilometri) throws SQLException {
        for (Integer id : kreiranaVozilaIds) {
            updatePrijedeniKilometriStatement.setInt(1, prijedeniKilometri);
            updatePrijedeniKilometriStatement.setInt(2, id);
            updatePrijedeniKilometriStatement.execute();
        }
    }

    private static void deleteVozilo(PreparedStatement deleteVoziloStatement, int... idVozilo) throws SQLException {
        for (int id : idVozilo) {
            deleteVoziloStatement.setInt(1, id);
            deleteVoziloStatement.execute();
        }
    }

    private static boolean acceptChanges() {
        System.out.println("Accept changes: y/n?");
        return new Scanner(System.in).next().matches("y|Y");
    }
    
    private static String generateString(int nrChars) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < nrChars; i++) {
            sb.append((char)ThreadLocalRandom.current().nextInt(97, 122));
        }        
        return sb.toString();
    }
    
    private static int getRandomNumber(int min, int max) {
	    return (int) ((Math.random() * (max - min)) + min);
    }
    
}
