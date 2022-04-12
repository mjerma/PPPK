/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import java.util.Collection;
import java.util.Date;
import javax.persistence.Basic;
import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author Mihael
 */
@Entity
@Table(name = "PutniNalog")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "PutniNalog.findAll", query = "SELECT p FROM PutniNalog p")
    , @NamedQuery(name = "PutniNalog.findByIDPutniNalog", query = "SELECT p FROM PutniNalog p WHERE p.iDPutniNalog = :iDPutniNalog")
    , @NamedQuery(name = "PutniNalog.findByNaredbodavac", query = "SELECT p FROM PutniNalog p WHERE p.naredbodavac = :naredbodavac")
    , @NamedQuery(name = "PutniNalog.findByBrojNaloga", query = "SELECT p FROM PutniNalog p WHERE p.brojNaloga = :brojNaloga")
    , @NamedQuery(name = "PutniNalog.findByPolaziste", query = "SELECT p FROM PutniNalog p WHERE p.polaziste = :polaziste")
    , @NamedQuery(name = "PutniNalog.findByOdrediste", query = "SELECT p FROM PutniNalog p WHERE p.odrediste = :odrediste")
    , @NamedQuery(name = "PutniNalog.findByBrojDana", query = "SELECT p FROM PutniNalog p WHERE p.brojDana = :brojDana")
    , @NamedQuery(name = "PutniNalog.findByDatumOtvaranja", query = "SELECT p FROM PutniNalog p WHERE p.datumOtvaranja = :datumOtvaranja")
    , @NamedQuery(name = "PutniNalog.findByDatumZatvaranja", query = "SELECT p FROM PutniNalog p WHERE p.datumZatvaranja = :datumZatvaranja")})
public class PutniNalog implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDPutniNalog")
    private Integer iDPutniNalog;
    @Column(name = "Naredbodavac")
    private String naredbodavac;
    @Basic(optional = false)
    @Column(name = "BrojNaloga")
    private int brojNaloga;
    @Basic(optional = false)
    @Column(name = "Polaziste")
    private String polaziste;
    @Basic(optional = false)
    @Column(name = "Odrediste")
    private String odrediste;
    @Basic(optional = false)
    @Column(name = "BrojDana")
    private int brojDana;
    @Basic(optional = false)
    @Column(name = "DatumOtvaranja")
    @Temporal(TemporalType.TIMESTAMP)
    private Date datumOtvaranja;
    @Column(name = "DatumZatvaranja")
    @Temporal(TemporalType.TIMESTAMP)
    private Date datumZatvaranja;
    @JoinColumn(name = "VozacID", referencedColumnName = "IDVozac")
    @ManyToOne(optional = false)
    private Vozac vozacID;
    @JoinColumn(name = "VoziloID", referencedColumnName = "IDVozilo")
    @ManyToOne(optional = false)
    private Vozilo voziloID;
    @OneToMany(cascade = CascadeType.ALL, mappedBy = "putniNalogID")
    private Collection<Ruta> rutaCollection;

    public PutniNalog() {
    }

    public PutniNalog(Integer iDPutniNalog) {
        this.iDPutniNalog = iDPutniNalog;
    }

    public PutniNalog(Integer iDPutniNalog, int brojNaloga, String polaziste, String odrediste, int brojDana, Date datumOtvaranja) {
        this.iDPutniNalog = iDPutniNalog;
        this.brojNaloga = brojNaloga;
        this.polaziste = polaziste;
        this.odrediste = odrediste;
        this.brojDana = brojDana;
        this.datumOtvaranja = datumOtvaranja;
    }

    public Integer getIDPutniNalog() {
        return iDPutniNalog;
    }

    public void setIDPutniNalog(Integer iDPutniNalog) {
        this.iDPutniNalog = iDPutniNalog;
    }

    public String getNaredbodavac() {
        return naredbodavac;
    }

    public void setNaredbodavac(String naredbodavac) {
        this.naredbodavac = naredbodavac;
    }

    public int getBrojNaloga() {
        return brojNaloga;
    }

    public void setBrojNaloga(int brojNaloga) {
        this.brojNaloga = brojNaloga;
    }

    public String getPolaziste() {
        return polaziste;
    }

    public void setPolaziste(String polaziste) {
        this.polaziste = polaziste;
    }

    public String getOdrediste() {
        return odrediste;
    }

    public void setOdrediste(String odrediste) {
        this.odrediste = odrediste;
    }

    public int getBrojDana() {
        return brojDana;
    }

    public void setBrojDana(int brojDana) {
        this.brojDana = brojDana;
    }

    public Date getDatumOtvaranja() {
        return datumOtvaranja;
    }

    public void setDatumOtvaranja(Date datumOtvaranja) {
        this.datumOtvaranja = datumOtvaranja;
    }

    public Date getDatumZatvaranja() {
        return datumZatvaranja;
    }

    public void setDatumZatvaranja(Date datumZatvaranja) {
        this.datumZatvaranja = datumZatvaranja;
    }

    public Vozac getVozacID() {
        return vozacID;
    }

    public void setVozacID(Vozac vozacID) {
        this.vozacID = vozacID;
    }

    public Vozilo getVoziloID() {
        return voziloID;
    }

    public void setVoziloID(Vozilo voziloID) {
        this.voziloID = voziloID;
    }

    @XmlTransient
    public Collection<Ruta> getRutaCollection() {
        return rutaCollection;
    }

    public void setRutaCollection(Collection<Ruta> rutaCollection) {
        this.rutaCollection = rutaCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDPutniNalog != null ? iDPutniNalog.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof PutniNalog)) {
            return false;
        }
        PutniNalog other = (PutniNalog) object;
        if ((this.iDPutniNalog == null && other.iDPutniNalog != null) || (this.iDPutniNalog != null && !this.iDPutniNalog.equals(other.iDPutniNalog))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Putni nalog [IDPutniNalog = " + iDPutniNalog + 
                ", Naredbodavac = " + naredbodavac +  ", Broj naloga = " + brojNaloga 
                + ", VozacID = " + vozacID.getIDVozac() + ", VoziloID = " + voziloID.getIDVozilo() + ", Polaziste = " 
                + polaziste + ", Odrediste = " + odrediste + ", Broj dana = " + brojDana 
                + ", Datum otvaranja = " + datumOtvaranja + ", Datum zatvaranja = " + datumZatvaranja + "]";
    }
    
}
