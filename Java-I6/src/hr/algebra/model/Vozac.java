/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import java.util.Collection;
import javax.persistence.Basic;
import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author Mihael
 */
@Entity
@Table(name = "Vozac")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Vozac.findAll", query = "SELECT v FROM Vozac v")
    , @NamedQuery(name = "Vozac.findByIDVozac", query = "SELECT v FROM Vozac v WHERE v.iDVozac = :iDVozac")
    , @NamedQuery(name = "Vozac.findByIme", query = "SELECT v FROM Vozac v WHERE v.ime = :ime")
    , @NamedQuery(name = "Vozac.findByPrezime", query = "SELECT v FROM Vozac v WHERE v.prezime = :prezime")
    , @NamedQuery(name = "Vozac.findByBrojMobitela", query = "SELECT v FROM Vozac v WHERE v.brojMobitela = :brojMobitela")
    , @NamedQuery(name = "Vozac.findByBrojVozackeDozvole", query = "SELECT v FROM Vozac v WHERE v.brojVozackeDozvole = :brojVozackeDozvole")})
public class Vozac implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDVozac")
    private Integer iDVozac;
    @Basic(optional = false)
    @Column(name = "Ime")
    private String ime;
    @Basic(optional = false)
    @Column(name = "Prezime")
    private String prezime;
    @Basic(optional = false)
    @Column(name = "BrojMobitela")
    private String brojMobitela;
    @Basic(optional = false)
    @Column(name = "BrojVozackeDozvole")
    private String brojVozackeDozvole;
    @OneToMany(cascade = CascadeType.ALL, mappedBy = "vozacID")
    private Collection<PutniNalog> putniNalogCollection;

    public Vozac() {
    }

    public Vozac(Integer iDVozac) {
        this.iDVozac = iDVozac;
    }

    public Vozac(Integer iDVozac, String ime, String prezime, String brojMobitela, String brojVozackeDozvole) {
        this.iDVozac = iDVozac;
        this.ime = ime;
        this.prezime = prezime;
        this.brojMobitela = brojMobitela;
        this.brojVozackeDozvole = brojVozackeDozvole;
    }

    public Integer getIDVozac() {
        return iDVozac;
    }

    public void setIDVozac(Integer iDVozac) {
        this.iDVozac = iDVozac;
    }

    public String getIme() {
        return ime;
    }

    public void setIme(String ime) {
        this.ime = ime;
    }

    public String getPrezime() {
        return prezime;
    }

    public void setPrezime(String prezime) {
        this.prezime = prezime;
    }

    public String getBrojMobitela() {
        return brojMobitela;
    }

    public void setBrojMobitela(String brojMobitela) {
        this.brojMobitela = brojMobitela;
    }

    public String getBrojVozackeDozvole() {
        return brojVozackeDozvole;
    }

    public void setBrojVozackeDozvole(String brojVozackeDozvole) {
        this.brojVozackeDozvole = brojVozackeDozvole;
    }

    @XmlTransient
    public Collection<PutniNalog> getPutniNalogCollection() {
        return putniNalogCollection;
    }

    public void setPutniNalogCollection(Collection<PutniNalog> putniNalogCollection) {
        this.putniNalogCollection = putniNalogCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDVozac != null ? iDVozac.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Vozac)) {
            return false;
        }
        Vozac other = (Vozac) object;
        if ((this.iDVozac == null && other.iDVozac != null) || (this.iDVozac != null && !this.iDVozac.equals(other.iDVozac))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "hr.algebra.model.Vozac[ iDVozac=" + iDVozac + " ]";
    }
    
}
