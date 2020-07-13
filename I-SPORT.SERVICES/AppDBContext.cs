using System;
using System.Collections.Generic;
using System.Text;
using I_SPORT.MODEL;
using Microsoft.EntityFrameworkCore;

namespace I_SPORT.SERVICES
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Jugador> jugadores {get;set;}
        public DbSet<Equipo> equipos { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Partido> partidos { get; set; }
        public DbSet<Estadisticas> estadisticas { get; set; }


    }
}
