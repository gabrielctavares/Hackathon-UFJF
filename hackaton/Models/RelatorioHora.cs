﻿namespace hackaton.Models
{
    public class RelatorioHora
    {
        public int Id { get; set; }
        public int DemandaId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Data { get; set; }
        public double Horas { get; set; }
    }
}