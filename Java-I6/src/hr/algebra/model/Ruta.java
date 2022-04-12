/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Mihael
 */
@Entity
@Table(name = "Ruta")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Ruta.findAll", query = "SELECT r FROM Ruta r")
    , @NamedQuery(name = "Ruta.findByIDRuta", query = "SELECT r FROM Ruta r WHERE r.iDRuta = :iDRuta")
    , @NamedQuery(name = "Ruta.findBySati", query = "SELECT r FROM Ruta r WHERE r.sati = :sati")
    , @NamedQuery(name = "Ruta.findByKoordinataA", query = "SELECT r FROM Ruta r WHERE r.koordinataA = :koordinataA")
    , @NamedQuery(name = "Ruta.findByKoordinataB", query = "SELECT r FROM Ruta r WHERE r.koordinataB = :koordinataB")
    , @NamedQuery(name = "Ruta.findByPrijedeniKilometri", query = "SELECT r FROM Ruta r WHERE r.prijedeniKilometri = :prijedeniKilometri")
    , @NamedQuery(name = "Ruta.findByProsjecnaBrzina", query = "SELECT r FROM Ruta r WHERE r.prosjecnaBrzina = :prosjecnaBrzina")
    , @NamedQuery(name = "Ruta.findByPotrosenoGorivo", query = "SELECT r FROM Ruta r WHERE r.potrosenoGorivo = :potrosenoGorivo")})
public class Ruta implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDRuta")
    private Integer iDRuta;
    @Basic(optional = false)
    @Column(name = "Sati")
    private int sati;
    @Basic(optional = false)
    @Column(name = "KoordinataA")
    private double koordinataA;
    @Basic(optional = false)
    @Column(name = "KoordinataB")
    private double koordinataB;
    @Basic(optional = false)
    @Column(name = "PrijedeniKilometri")
    private int prijedeniKilometri;
    @Basic(optional = false)
    @Column(name = "ProsjecnaBrzina")
    private int prosjecnaBrzina;
    @Basic(optional = false)
    @Column(name = "PotrosenoGorivo")
    private double potrosenoGorivo;
    @JoinColumn(name = "PutniNalogID", referencedColumnName = "IDPutniNalog")
    @ManyToOne(optional = false)
    private PutniNalog putniNalogID;

    public Ruta() {
    }

    public Ruta(Integer iDRuta) {
        this.iDRuta = iDRuta;
    }

    public Ruta(Integer iDRuta, int sati, double koordinataA, double koordinataB, int prijedeniKilometri, int prosjecnaBrzina, double potrosenoGorivo) {
        this.iDRuta = iDRuta;
        this.sati = sati;
        this.koordinataA = koordinataA;
        this.koordinataB = koordinataB;
        this.prijedeniKilometri = prijedeniKilometri;
        this.prosjecnaBrzina = prosjecnaBrzina;
        this.potrosenoGorivo = potrosenoGorivo;
    }

    public Integer getIDRuta() {
        return iDRuta;
    }

    public void setIDRuta(Integer iDRuta) {
        this.iDRuta = iDRuta;
    }

    public int getSati() {
        return sati;
    }

    public void setSati(int sati) {
        this.sati = sati;
    }

    public double getKoordinataA() {
        return koordinataA;
    }

    public void setKoordinataA(double koordinataA) {
        this.koordinataA = koordinataA;
    }

    public double getKoordinataB() {
        return koordinataB;
    }

    public void setKoordinataB(double koordinataB) {
        this.koordinataB = koordinataB;
    }

    public int getPrijedeniKilometri() {
        return prijedeniKilometri;
    }

    public void setPrijedeniKilometri(int prijedeniKilometri) {
        this.prijedeniKilometri = prijedeniKilometri;
    }

    public int getProsjecnaBrzina() {
        return prosjecnaBrzina;
    }

    public void setProsjecnaBrzina(int prosjecnaBrzina) {
        this.prosjecnaBrzina = prosjecnaBrzina;
    }

    public double getPotrosenoGorivo() {
        return potrosenoGorivo;
    }

    public void setPotrosenoGorivo(double potrosenoGorivo) {
        this.potrosenoGorivo = potrosenoGorivo;
    }

    public PutniNalog getPutniNalogID() {
        return putniNalogID;
    }

    public void setPutniNalogID(PutniNalog putniNalogID) {
        this.putniNalogID = putniNalogID;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDRuta != null ? iDRuta.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Ruta)) {
            return false;
        }
        Ruta other = (Ruta) object;
        if ((this.iDRuta == null && other.iDRuta != null) || (this.iDRuta != null && !this.iDRuta.equals(other.iDRuta))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "hr.algebra.model.Ruta[ iDRuta=" + iDRuta + " ]";
    }
    
}
