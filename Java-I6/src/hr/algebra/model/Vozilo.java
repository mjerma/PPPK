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
@Table(name = "Vozilo")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Vozilo.findAll", query = "SELECT v FROM Vozilo v")
    , @NamedQuery(name = "Vozilo.findByIDVozilo", query = "SELECT v FROM Vozilo v WHERE v.iDVozilo = :iDVozilo")
    , @NamedQuery(name = "Vozilo.findByTip", query = "SELECT v FROM Vozilo v WHERE v.tip = :tip")
    , @NamedQuery(name = "Vozilo.findByMarka", query = "SELECT v FROM Vozilo v WHERE v.marka = :marka")
    , @NamedQuery(name = "Vozilo.findByGodinaProizvodnje", query = "SELECT v FROM Vozilo v WHERE v.godinaProizvodnje = :godinaProizvodnje")
    , @NamedQuery(name = "Vozilo.findByPrijedeniKilometri", query = "SELECT v FROM Vozilo v WHERE v.prijedeniKilometri = :prijedeniKilometri")
    , @NamedQuery(name = "Vozilo.findByJeSlobodno", query = "SELECT v FROM Vozilo v WHERE v.jeSlobodno = :jeSlobodno")})
public class Vozilo implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDVozilo")
    private Integer iDVozilo;
    @Basic(optional = false)
    @Column(name = "Tip")
    private String tip;
    @Basic(optional = false)
    @Column(name = "Marka")
    private String marka;
    @Basic(optional = false)
    @Column(name = "GodinaProizvodnje")
    private int godinaProizvodnje;
    @Basic(optional = false)
    @Column(name = "PrijedeniKilometri")
    private int prijedeniKilometri;
    @Basic(optional = false)
    @Column(name = "JeSlobodno")
    private boolean jeSlobodno;
    @OneToMany(cascade = CascadeType.ALL, mappedBy = "voziloID")
    private Collection<PutniNalog> putniNalogCollection;

    public Vozilo() {
    }

    public Vozilo(Integer iDVozilo) {
        this.iDVozilo = iDVozilo;
    }

    public Vozilo(Integer iDVozilo, String tip, String marka, int godinaProizvodnje, int prijedeniKilometri, boolean jeSlobodno) {
        this.iDVozilo = iDVozilo;
        this.tip = tip;
        this.marka = marka;
        this.godinaProizvodnje = godinaProizvodnje;
        this.prijedeniKilometri = prijedeniKilometri;
        this.jeSlobodno = jeSlobodno;
    }

    public Integer getIDVozilo() {
        return iDVozilo;
    }

    public void setIDVozilo(Integer iDVozilo) {
        this.iDVozilo = iDVozilo;
    }

    public String getTip() {
        return tip;
    }

    public void setTip(String tip) {
        this.tip = tip;
    }

    public String getMarka() {
        return marka;
    }

    public void setMarka(String marka) {
        this.marka = marka;
    }

    public int getGodinaProizvodnje() {
        return godinaProizvodnje;
    }

    public void setGodinaProizvodnje(int godinaProizvodnje) {
        this.godinaProizvodnje = godinaProizvodnje;
    }

    public int getPrijedeniKilometri() {
        return prijedeniKilometri;
    }

    public void setPrijedeniKilometri(int prijedeniKilometri) {
        this.prijedeniKilometri = prijedeniKilometri;
    }

    public boolean getJeSlobodno() {
        return jeSlobodno;
    }

    public void setJeSlobodno(boolean jeSlobodno) {
        this.jeSlobodno = jeSlobodno;
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
        hash += (iDVozilo != null ? iDVozilo.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Vozilo)) {
            return false;
        }
        Vozilo other = (Vozilo) object;
        if ((this.iDVozilo == null && other.iDVozilo != null) || (this.iDVozilo != null && !this.iDVozilo.equals(other.iDVozilo))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "hr.algebra.model.Vozilo[ iDVozilo=" + iDVozilo + " ]";
    }
    
}
