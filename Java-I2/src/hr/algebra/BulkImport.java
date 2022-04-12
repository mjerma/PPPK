/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra;

import hr.algebra.dao.SqlHandler;
import hr.algebra.model.Vozac;
import hr.algebra.model.Vozilo;
import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.ThreadLocalRandom;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Mihael
 */
public class BulkImport {
    
    public static void main(String[] args) throws IOException {
        createFakeVozila(100);
        createFakeVozaci(100);
        List<Vozilo> vozila = loadVozilaFromCSV();
        List<Vozac> vozaci = loadVozaciFromCSV();
        SqlHandler.insertVozila(vozila, 1000);
        SqlHandler.insertVozaci(vozaci, 1000);
    }

    private static List<Vozac> loadVozaciFromCSV() {
        List<Vozac> vozaci = new ArrayList<>();
        
        try (BufferedReader br = new BufferedReader(new FileReader("Vozaci.csv"))) {
	    String line;
	    while ((line = br.readLine()) != null) {
	        String[] values = line.split(",");
	        vozaci.add(new Vozac(values[0],values[1],values[2],values[3]));
	    }
	} catch (IOException ex) {
            Logger.getLogger(BulkImport.class.getName()).log(Level.SEVERE, null, ex);
        }
        return vozaci;
    }
    
    private static List<Vozilo> loadVozilaFromCSV() throws FileNotFoundException {
        List<Vozilo> vozila = new ArrayList<>();
        
        try (BufferedReader br = new BufferedReader(new FileReader("Vozila.csv"))) {
	    String line;
	    while ((line = br.readLine()) != null) {
	        String[] values = line.split(",");
	        vozila.add(new Vozilo(values[0],values[1],Integer.parseInt(values[2]),Integer.parseInt(values[3]),Boolean.parseBoolean(values[4])));
	    }
	} catch (IOException ex) {
            Logger.getLogger(BulkImport.class.getName()).log(Level.SEVERE, null, ex);
        }
        return vozila;
    }

    private static void createFakeVozila(int size) throws IOException {
        try (FileWriter csvWriter = new FileWriter("Vozila.csv")) {
            for (int i = 0; i < size; i++) {
                csvWriter.append(generateString(6));
                csvWriter.append(",");
                csvWriter.append(generateString(6));
                csvWriter.append(",");
                csvWriter.append(String.valueOf(getRandomNumber(1950, 2020)));
                csvWriter.append(",");
                csvWriter.append(String.valueOf(getRandomNumber(1, 500000)));
                csvWriter.append(",");
                csvWriter.append("true");
                csvWriter.append("\n");
            }
            csvWriter.flush();
        }
    }
    
    private static void createFakeVozaci(int size) throws IOException {
        try (FileWriter csvWriter = new FileWriter("Vozaci.csv")) {
            for (int i = 0; i < size; i++) {
                csvWriter.append(generateString(6));
                csvWriter.append(",");
                csvWriter.append(generateString(6));
                csvWriter.append(",");
                csvWriter.append(String.valueOf(getRandomNumber(3151253, 9125250)));
                csvWriter.append(",");
                csvWriter.append(String.valueOf(getRandomNumber(1, 999999)));
                csvWriter.append("\n");
            }
            csvWriter.flush();
        }
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
