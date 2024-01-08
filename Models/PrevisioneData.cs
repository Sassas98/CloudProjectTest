namespace CloudProjectTest.Models {
    
    public class PrevisioneData {
        public string fontedacitare { get; set; }
        public string codiceipatitolare { get; set; }
        public string nometitolare { get; set; }
        public string codiceipaeditore { get; set; }
        public string nomeeditore { get; set; }
        public string dataPubblicazione { get; set; }
        public int idPrevisione { get; set; }
        public string evoluzione { get; set; }
        public string evoluzioneBreve { get; set; }
        public Previsione[] previsione { get; set; }
    }

    public class Previsione {
        public string localita { get; set; }
        public int quota { get; set; }
        public Giorni[] giorni { get; set; }
    }

    public class Giorni {
        public int idPrevisioneGiorno { get; set; }
        public string giorno { get; set; }
        public int idIcona { get; set; }
        public string icona { get; set; }
        public string descIcona { get; set; }
        public string testoGiorno { get; set; }
        public int tMinGiorno { get; set; }
        public int tMaxGiorno { get; set; }
        public Fasce[] fasce { get; set; }
    }

    public class Fasce {
        public int idPrevisioneFascia { get; set; }
        public string fascia { get; set; }
        public string fasciaPer { get; set; }
        public string fasciaOre { get; set; }
        public string icona { get; set; }
        public string descIcona { get; set; }
        public string idPrecProb { get; set; }
        public string descPrecProb { get; set; }
        public string idPrecInten { get; set; }
        public string descPrecInten { get; set; }
        public string idTempProb { get; set; }
        public string descTempProb { get; set; }
        public string idVentoIntQuota { get; set; }
        public string descVentoIntQuota { get; set; }
        public string idVentoDirQuota { get; set; }
        public string descVentoDirQuota { get; set; }
        public string idVentoIntValle { get; set; }
        public string descVentoIntValle { get; set; }
        public string idVentoDirValle { get; set; }
        public string descVentoDirValle { get; set; }
        public string iconaVentoQuota { get; set; }
        public int zeroTermico { get; set; }
        public int limiteNevicate { get; set; }
    }

}