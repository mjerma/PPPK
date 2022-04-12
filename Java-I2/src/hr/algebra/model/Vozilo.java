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
public class Vozilo {
    private int IDVozilo;
    private String Tip;
    private String Marka;
    private int GodinaProizvodnje;
    private int PrijedeniKilometri;
    private Boolean JeSlobodno;

    public Vozilo(String Tip, String Marka, int GodinaProizvodnje, int PrijedeniKilometri, Boolean JeSlobodno) {
        this.Tip = Tip;
        this.Marka = Marka;
        this.GodinaProizvodnje = GodinaProizvodnje;
        this.PrijedeniKilometri = PrijedeniKilometri;
        this.JeSlobodno = JeSlobodno;
    }

    public Vozilo(int IDVozilo, String Tip, String Marka, int GodinaProizvodnje, int PrijedeniKilometri, Boolean JeSlobodno) {
        this(Tip, Marka, GodinaProizvodnje,PrijedeniKilometri,JeSlobodno);
        this.IDVozilo = IDVozilo;
    }

    public int getIDVozilo() {
        return IDVozilo;
    }

    public String getTip() {
        return Tip;
    }

    public String getMarka() {
        return Marka;
    }

    public int getGodinaProizvodnje() {
        return GodinaProizvodnje;
    }

    public int getPrijedeniKilometri() {
        return PrijedeniKilometri;
    }

    public Boolean getJeSlobodno() {
        return JeSlobodno;
    }
    
    @Override
    public String toString() {
        return String.format("Kolegij %d, %s, %s, %d, %d, %s", IDVozilo, Tip, Marka, GodinaProizvodnje, PrijedeniKilometri, JeSlobodno);
    }
}
