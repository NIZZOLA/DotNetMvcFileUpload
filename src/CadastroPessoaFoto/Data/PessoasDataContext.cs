using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroPessoaFoto.Models;

    public class PessoasDataContext : DbContext
    {
        public PessoasDataContext (DbContextOptions<PessoasDataContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroPessoaFoto.Models.PessoaModel> PessoaModel { get; set; }
    }
