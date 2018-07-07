﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Modelos
{
    public class Contexto : Dbcontext
    {
        public Contexto() : base("strConn")  // base = (super do java), "strConn" = nome da conexão com banco
        {

        }
    }
    public DbSet<Aluno> Alunos { get; set; }  // tabela de alunos
}