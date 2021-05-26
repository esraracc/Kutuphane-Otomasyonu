using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphane.DAL;
using ZedGraph;

namespace kutuphane.BLL
{
    public class GrafikBLL
    {
        private GrafikDAL grafikDal;
        public GrafikBLL()
        {
            grafikDal = new GrafikDAL();
        }
        public void zedgraph(ZedGraphControl zedGraph)
        {
            grafikDal.zedgraph(zedGraph);
        }
        public string TumK
        {
            get { return grafikDal.tumK; }
            set { grafikDal.tumK = value; }
        }
        public string EmanetVerilen
        {
            get { return grafikDal.emanetVerilen; }
            set { grafikDal.emanetVerilen = value; }
        }
        public string EmanetVerilmeyen
        {
            get { return grafikDal.emanetVerilmeyen; }
            set { grafikDal.emanetVerilmeyen = value; }
        }
    }
}
