using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo.Clonable
{
    public abstract class Shape : ICloneable
    {
        private string id;
        protected string type;

        public abstract void draw();

        public string GetType()
        {
            return type;
        }

        public string GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
