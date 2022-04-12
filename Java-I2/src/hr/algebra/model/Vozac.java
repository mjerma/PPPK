/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

/**
 *
 * @author Mihael
 */
public class Vozac {
    public int IDVozac;
    public String Ime;
    public String Prezime;
    public String BrojMobitela;
    public String BrojVozackeDozvole;

    public Vozac(String Ime, String Prezime, String BrojMobitela, String BrojVozackeDozvole) {
        this.Ime = Ime;
        this.Prezime = Prezime;
        this.BrojMobitela = BrojMobitela;
        this.BrojVozackeDozvole = BrojVozackeDozvole;
    }

    public Vozac(int IDVozac, String Ime, String Prezime, String BrojMobitela, String BrojVozackeDozvole) {
        this(Ime, Prezime, BrojMobitela,BrojVozackeDozvole);
        this.IDVozac = IDVozac;
    }

    public int getIDVozac() {
        return IDVozac;
    }

    public String getIme() {
        return Ime;
    }

    public String getPrezime() {
        return Prezime;
    }

    public String getBrojMobitela() {
        return BrojMobitela;
    }

    public String getBrojVozackeDozvole() {
        return BrojVozackeDozvole;
    }
    
    
}
