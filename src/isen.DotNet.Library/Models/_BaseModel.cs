using System;

namespace isen.DotNet.Library.Models
{
    public abstract class BaseModel
    {
        public virtual int Id { get; set; }
        public virtual string Name{ get; set;}

        public virtual string Display =>
            $"[{this.GetType()}] Id={Id}|Name={Name}";

        public override string ToString() => Display;
    }
}