using System;
using System.Security.Cryptography;
using Tp_Integrador_Final.Enums;

namespace Tp_Integrador_Final.Modelos
{
    public class Reserva
    {
        private int id = RandomNumberGenerator.GetInt32(1000000, 9999999);
        private int salaId;
        private int usuarioId;
        private DateTime fechaReserva;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;
        private string motivo;
        private ReservaEstadoEnum estado = ReservaEstadoEnum.Pendiente;

        public int Id { get => id; set => id = value; }
        public int SalaId { get => salaId; set => salaId = value; }
        public int UsuarioId { get => usuarioId; set => usuarioId = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }

        public TimeSpan HoraInicio
        {
            get => horaInicio;
            set
            {
                if (value < TimeSpan.Zero || value >= TimeSpan.FromDays(1))
                    throw new ArgumentException("La hora de inicio debe estar entre 00:00 y 23:59.");
                horaInicio = value;
            }
        }

        public TimeSpan HoraFin
        {
            get => horaFin;
            set
            {
                if (value <= horaInicio)
                    throw new ArgumentException("La hora de fin debe ser posterior a la hora de inicio.");
                if (value < TimeSpan.Zero || value > TimeSpan.FromDays(1))
                    throw new ArgumentException("La hora de fin debe estar entre 00:00 y 23:59.");
                horaFin = value;
            }
        }

        public string Motivo { get => motivo; set => motivo = value; }
        public ReservaEstadoEnum Estado { get => estado; set => estado = value; }

        public TimeSpan DuracionReserva => horaFin - horaInicio;
        public bool EstaVencida => fechaReserva < DateTime.Today || (fechaReserva == DateTime.Today && horaFin <= DateTime.Now.TimeOfDay);

        public Reserva() { }

        public Reserva(int salaId, int usuarioId, DateTime fechaReserva, TimeSpan horaInicio, TimeSpan horaFin)
            : this(salaId, usuarioId, fechaReserva, horaInicio, horaFin, null) { }

        public Reserva(int salaId, int usuarioId, DateTime fechaReserva, TimeSpan horaInicio, TimeSpan horaFin, string motivo)
        {
            SalaId = salaId;
            UsuarioId = usuarioId;
            FechaReserva = fechaReserva;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            Motivo = motivo;
        }

        public override string ToString()
        {
            return $"{Id}|{SalaId}|{UsuarioId}|{FechaReserva:yyyy-MM-dd}|{HoraInicio:hh\\:mm}|{HoraFin:hh\\:mm}|{Motivo ?? ""}|{(int)Estado}";
        }
    }
}
