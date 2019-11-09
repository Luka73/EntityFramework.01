using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.DAL.Entities;

namespace Projeto.DAL.Mapping
{
    //REGRA 1) Herdar a classe EntityTypeConfiguration
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {

        }
    }
}
