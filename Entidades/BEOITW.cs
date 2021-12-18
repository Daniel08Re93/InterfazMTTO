using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfazMTTO.iSBO_BE
{
    public class BEOITW
    {
        private string _CodigoArticulo;
        private double _CostoArticulo;

        public string CodigoArticulo
        {
            get { return _CodigoArticulo; }
            set { _CodigoArticulo = value; }
        }

        public double CostoArticulo
        {
            get { return _CostoArticulo; }
            set { _CostoArticulo = value; }
        }
    }

    public class BEOITWList : List<BEOITW>, ICloneable
    {
        public BEOITWList()
        {
        }

        private BEOITWList(BEOITWList listaMembers)
        {
            foreach (BEOITW beValor in listaMembers)
            {
                this.Add(beValor);
            }
        }

        public object Clone()
        {
            return new BEOITWList(this);
        }

    }
}
