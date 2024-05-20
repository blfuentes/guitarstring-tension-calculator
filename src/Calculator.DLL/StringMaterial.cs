using System.ComponentModel;
using Calculator.DLL.Helpers;

namespace Calculator.DLL
{
    public class StringMaterial
    {
        public StringMaterial(MaterialType materialType)
        {
            this.Material = materialType;
        }
        public StringMaterial()
        {

        }

        public MaterialType Material;
        public double Density
        {
            get
            {
                double _d = 0.0;

                switch (this.Material)
                {
                    case MaterialType.GUT:
                        _d = 1360;
                        break;
                    case MaterialType.NYLON:
                        _d = 1140.0;
                        break;
                    case MaterialType.STEEL:
                        _d = 7850.0;
                        break;
                    case MaterialType.STAINLESS_STEEL:
                        _d = 7800.0; // 7480 - 8000
                        break;
                    case MaterialType.NICKEL_PLATED:
                        _d = 8100.0;
                        break;
                    default:
                        _d = 7800;
                        break;
                }

                return _d;
            }
        }

        public override string ToString()
        {
            return (this.Material.ToStringEnums());
        }

    }

    public enum MaterialType
    {
        [Description("Gut")]
        GUT,
        [Description("Nylon")]
        NYLON,
        [Description("Steel")]
        STEEL,
        [Description("Stainless steel")]
        STAINLESS_STEEL,

        //
        [Description("Plain steel")]
        PLAIN_STEEL,
        [Description("Nickel plated")]
        NICKEL_PLATED,
        [Description("Chromes")]
        CHROMES
    }
}
