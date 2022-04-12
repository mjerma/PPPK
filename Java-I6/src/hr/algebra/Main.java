/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra;

import hr.algebra.model.PutniNalog;
import hr.algebra.model.Ruta;
import hr.algebra.model.Vozac;
import hr.algebra.model.Vozilo;
import java.io.IOException;
import java.util.Collection;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.PDPageContentStream;
import org.apache.pdfbox.pdmodel.font.PDType1Font;

/**
 *
 * @author Mihael
 */
public class Main {
    
    private static final String PDF_PATH = "putniNalog_id_%d.pdf";
    
    public static void main(String[] args) {
        EntityManagerFactory emf = null;
        try {
            emf = Persistence.createEntityManagerFactory("Java-I6PU");
            printPutniNalozi(emf);
            createPdf(emf, 2);
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (emf != null) {
                emf.close();
            }
        }
    }

    private static void printPutniNalozi(EntityManagerFactory emf) {
        EntityManager em = null;
        try {
            em = emf.createEntityManager();
            em.getTransaction().begin();
            
            Query query = em.createNativeQuery("select * from PutniNalog", PutniNalog.class);
            query.getResultList().forEach(System.out::println);
            
            em.getTransaction().commit();
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (em != null) {
                em.close();
            }
        }
    }

    private static void createPdf(EntityManagerFactory emf, int IDPutniNalog) {

        try (PDDocument doc = new PDDocument()) {
            PDPage myPage = new PDPage();
            doc.addPage(myPage);
            try (PDPageContentStream content = new PDPageContentStream(doc, myPage)) {

                content.beginText();

                PutniNalog putniNalog = getPutniNalogFromDB(emf, IDPutniNalog);

                content.setFont(PDType1Font.TIMES_BOLD, 16);
                content.setLeading(14.5f);
                content.newLineAtOffset(25, 700);

                // Putni nalog
                String putniNalogLine = String.format("Putni nalog");
                content.showText(putniNalogLine);
                content.newLine();
                content.setFont(PDType1Font.TIMES_ROMAN, 12);
                content.newLine();
                String putniNalogData = String.format("Naredbodavac: " + 
                        putniNalog.getNaredbodavac() + ", Polazište: " + 
                        putniNalog.getPolaziste() + ", Odredište: " +
                        putniNalog.getOdrediste()
                );
                content.showText(putniNalogData);
                content.newLine();
                
                // Vozilo
                content.newLine();
                content.setFont(PDType1Font.TIMES_BOLD, 16);
                String voziloLine = "Vozilo";
                content.showText(voziloLine);
                content.newLine();

                content.setFont(PDType1Font.TIMES_ROMAN, 12);
                content.newLine();
                Vozilo vozilo = putniNalog.getVoziloID();
                String voziloData = String.format("%s %s, %d., %dkm",
                        vozilo.getTip(),
                        vozilo.getMarka(),
                        vozilo.getGodinaProizvodnje(),
                        vozilo.getPrijedeniKilometri()
                );
                content.showText(voziloData);

                content.setFont(PDType1Font.TIMES_BOLD, 16);
                content.newLine();

                // Vozac
                content.newLine();
                String vozacLine = "Vozac";
                content.showText(vozacLine);
                content.newLine();

                content.setFont(PDType1Font.TIMES_ROMAN, 12);
                content.newLine();
                Vozac vozac = putniNalog.getVozacID();
                String vozacData = String.format("%s %s, %s, %s",
                        vozac.getIme(),
                        vozac.getPrezime(),
                        vozac.getBrojMobitela(),
                        vozac.getBrojVozackeDozvole()
                );
                content.showText(vozacData);
                content.newLine();
                
                content.setFont(PDType1Font.TIMES_BOLD, 16);
                content.newLine();

                content.endText();
            }

            doc.save(String.format(PDF_PATH, IDPutniNalog));
        } catch (IOException ex) {
            Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private static PutniNalog getPutniNalogFromDB(EntityManagerFactory emf, int id) {
        EntityManager em = null;
        PutniNalog putniNalog = null;

        try {
            em = emf.createEntityManager();
            em.getTransaction().begin();

            putniNalog = em.find(PutniNalog.class, id);

            em.getTransaction().commit();
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (em != null) {
                em.close();
            }
        }

        return putniNalog;
    }
}
