using System;
using System.Collections.Generic;
using System.Text;

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

    }

    public enum MaterialType
    {
        GUT,
        NYLON,
        STEEL,
        STAINLESS_STEEL,
        
        //
        PLAIN_STEEL,
        NICKEL_PLATED,
        CHROMES
    }
}
