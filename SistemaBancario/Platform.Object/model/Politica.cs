using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Politica
    {
        private Int32 id;
        private String mision;
        private String vision;

        public Politica()
        {

        }
        public Int32 getId()
        {
            return this.id;
        }
        public void setId(Int32 id)
        {
            this.id = id;
        }

        public String getMision()
        {
            return this.mision;
        }
        public void setMision(String mision)
        {
            this.mision = mision;
        }

        public String getVision()
        {
            return this.vision;
        }
        public void setVision(String vision)
        {
            this.vision = vision;
        }
    }
}
