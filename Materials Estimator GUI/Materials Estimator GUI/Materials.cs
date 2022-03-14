using System;

namespace Materials_Estimator
{
    public class Material
    {
        //Encapsulated Variables
        private Material[] materialList; // List of all materials
        private String materialName;
        private double unitPrice;
        private string category; // can only be accessed by derived classes and set via constructor. 
        private int materialQuantity;
        private double grandTotal;
        // Properties
        public Material[] MaterialList // MaterialList will contain every record saved in the Estimator
        {
            get { return materialList; }
            set { materialList = value; }
        }
        public String MaterialName // Name of constructed Object
        {
            get { return materialName; }
            set { materialName = value; }
        }
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int MaterialQuantity // This will simply contain a total number of items for a singular entry in any derived class
        {
            get { return materialQuantity; }
            set { materialQuantity = value; }
        }
        public double GrandTotal // Grand total of every item in the materialList[] array
        {
            get { return grandTotal; }
            set { grandTotal = value; }
        }
        // Methods
        public double CalculateGrandTotal() 
        {
            double total = 0;
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                total += MaterialList[x].UnitPrice;
            }
            this.GrandTotal = total;
            return total;
        }

        /*
         * Note: may be able to clear data in arrays by reassigning
         *  # of elements in them; resets value of all elements in
         *  array to defaults
        */
        public void ClearMaterialList()
        {
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                this.MaterialList[x].MaterialName = ""; // Clear entry
                this.MaterialList[x].UnitPrice = 0.0; // Clear price
                this.MaterialList[x].materialQuantity = 0;
            }
        }
        public void CreateExcelFile() // Used with "Save" button to file write a csv.
        {
            // Define Later
        }
        public Material() // Defualt Constructor
        {
            this.UnitPrice = 0.0;
            this.MaterialQuantity = 1;
            this.MaterialName = "Material";
        }
        public Material(string materialName, double unitPrice, int materialQuantity) // Creates a Material object based on user input
        {
            this.MaterialName = materialName;
            this.unitPrice = unitPrice;
            this.materialQuantity = materialQuantity;
        }
    }
    public class Masonry : Material
    {
        public string category = "Masonry"; // Category for reference in MaterialList[] in Material Class
        double totalEstimatedMasonry;

        public double TotalEstimatedMasonry
        {
            get { return totalEstimatedMasonry; }
            set { totalEstimatedMasonry = value; }
        }
        public double CalculateMasonryTotal()
        {
            double total = 0;
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    total += MaterialList[x].UnitPrice;
                }
            }
            this.totalEstimatedMasonry = total;
            return total;
        }
        public void ClearMasonryList()
        {
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == "Masonry")
                {
                 this.MaterialList[x].MaterialName = "";
                 this.MaterialList[x].UnitPrice = 0.0;
                 this.MaterialList[x].MaterialQuantity = 0;
                }
            }
        }
        public Masonry() // default constructor. 
        {
            this.MaterialName = "Masonry Material";
            this.UnitPrice = 0.0;
            this.MaterialQuantity = 1;
        }
        public Masonry(string materialName, double unitPrice, int materialQuantity) : base(materialName, unitPrice, materialQuantity) // Extends base constructor. 
        {
            this.MaterialName = materialName; // Exeption will need created to ensure a name is entered. 
            this.UnitPrice = unitPrice; // Exception will need created to ensure unitPrice is not below 0
            this.MaterialQuantity = materialQuantity;
        }
    }

        public class Plumbing : Material
    {
        public string category = "Plumbing"; // Category for reference in MaterialList[] in Material Class
        private double totalEstimatedPlumbing;

        public double TotalEstimatedPlumbing
        {
            get { return totalEstimatedPlumbing; }
            set { totalEstimatedPlumbing = value; }
        }
        public double CalculatePlumbingTotal()
        {
            double total = 0;
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    total += MaterialList[x].UnitPrice;
                }
            }
            this.totalEstimatedPlumbing = total;
            return total;
        }
        public void ClearPlumbingList()
        {
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    this.MaterialList[x].MaterialName = "";
                    this.MaterialList[x].UnitPrice = 0.0;
                    this.MaterialList[x].MaterialQuantity = 0;
                }
            }
        }
        public Plumbing() // default constructor. 
        {
            this.MaterialName = "Plumbing Material";
            this.UnitPrice = 0.0;
            this.MaterialQuantity = 1;
            this.category = "Plumbing";
        }
        public Plumbing(string materialName, double unitPrice, int materialQuantity) : base(materialName, unitPrice, materialQuantity) // Extends base constructor. 
        {
            this.MaterialName = materialName; // Exeption will need created to ensure a name is entered. 
            this.UnitPrice = unitPrice; // Exception will need created to ensure unitPrice is not below 0
            this.MaterialQuantity = materialQuantity;
        }
    }

    public class Electric : Material
    {
        public string category = "Electric"; // Category for reference in MaterialList[] in Material Class
        private double totalEstimatedElectric;

        public double TotalEstimatedElectric
        {
            get { return totalEstimatedElectric; }
            set { totalEstimatedElectric = value; }
        }
        public double CalculateElectricTotal()
        {
            double total = 0;
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    total += MaterialList[x].UnitPrice;
                }
            }
            this.totalEstimatedElectric = total;
            return total;
        }
        public void ClearElectricList()
        {
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    this.MaterialList[x].MaterialName = "";
                    this.MaterialList[x].UnitPrice = 0.0;
                    this.MaterialList[x].MaterialQuantity = 0;
                }
            }
        }
        public Electric() // default constructor. 
        {
            this.MaterialName = "Plumbing Material";
            this.UnitPrice = 0.0;
            this.MaterialQuantity = 1;
            this.category = "Plumbing";
        }
        public Electric(string materialName, double unitPrice, int materialQuantity) : base(materialName, unitPrice, materialQuantity) // Extends base constructor. 
        {
            this.MaterialName = materialName; // Exeption will need created to ensure a name is entered. 
            this.UnitPrice = unitPrice; // Exception will need created to ensure unitPrice is not below 0
            this.MaterialQuantity = materialQuantity;
        }
    }

    public class HVAC : Material
    {
        public string category = "HVAC"; // Category for reference in MaterialList[] in Material Class
        private double totalEstimatedHVAC;

        public double TotalEstimatedHVAC
        {
            get { return totalEstimatedHVAC; }
            set { totalEstimatedHVAC = value; }
        }
        public double CalculateHVACTotal()
        {
            double total = 0;
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    total += MaterialList[x].UnitPrice;
                }
            }
            this.totalEstimatedHVAC = total; // set new total
            return total; 
        }
        public void ClearHVACList()
        {
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    this.MaterialList[x].MaterialName = "";
                    this.MaterialList[x].UnitPrice = 0.0;
                    this.MaterialList[x].MaterialQuantity = 0;
                }
            }
        }
        public HVAC() // default constructor. 
        {
            this.MaterialName = "HVAC Material";
            this.UnitPrice = 0.0;
            this.MaterialQuantity = 1;
            this.category = "HVAC";
        }
        public HVAC(string materialName, double unitPrice, int materialQuantity) : base(materialName, unitPrice, materialQuantity) // Extends base constructor. 
        {
            this.MaterialName = materialName; // Exeption will need created to ensure a name is entered. 
            this.UnitPrice = unitPrice; // Exception will need created to ensure unitPrice is not below 0
            this.MaterialQuantity = materialQuantity;
        }
    }

    public class Insulation : Material
    {
        public string category = "Insulation"; // Category for reference in MaterialList[] in Material Class
        private double totalEstimatedInsulation;

        public double TotalEstimatedPlumbing
        {
            get { return totalEstimatedInsulation; }
            set { totalEstimatedInsulation = value; }
        }
        public double CalculateInsulationTotal()
        {
            double total = 0;
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    total += MaterialList[x].UnitPrice;
                }
            }
            this.totalEstimatedInsulation = total;
            return total;
        }
        public void ClearInsulationList()
        {
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    this.MaterialList[x].MaterialName = "";
                    this.MaterialList[x].UnitPrice = 0.0;
                    this.MaterialList[x].MaterialQuantity = 0;
                }
            }
        }
        public Insulation() // default constructor. 
        {
            this.MaterialName = "Insulation Material";
            this.UnitPrice = 0.0;
            this.MaterialQuantity = 1;
            this.category = "Insulation";
        }
        public Insulation(string materialName, double unitPrice, int materialQuantity) : base(materialName, unitPrice, materialQuantity) // Extends base constructor. 
        {
            this.MaterialName = materialName; // Exeption will need created to ensure a name is entered. 
            this.UnitPrice = unitPrice; // Exception will need created to ensure unitPrice is not below 0
            this.MaterialQuantity = materialQuantity;
        }
    }

    public class Flooring : Material
    {
        public string category = "Flooring"; // Category for reference in MaterialList[] in Material Class
        private double totalEstimatedFlooring;

        public double TotalEstimatedFlooring
        {
            get { return totalEstimatedFlooring; }
            set { totalEstimatedFlooring = value; }
        }
        public double CalculateFlooringTotal()
        {
            double total = 0;
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    total += MaterialList[x].UnitPrice;
                }
            }
            this.totalEstimatedFlooring = total;
            return total;
        }
        public void ClearFlooringList()
        {
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    this.MaterialList[x].MaterialName = "";
                    this.MaterialList[x].UnitPrice = 0.0;
                    this.MaterialList[x].MaterialQuantity = 0;
                }
            }
        }
        public Flooring() // default constructor. 
        {
            this.MaterialName = "Plumbing Material";
            this.UnitPrice = 0.0;
            this.MaterialQuantity = 1;
            this.category = "Plumbing";
        }
        public Flooring(string materialName, double unitPrice, int materialQuantity) : base(materialName, unitPrice, materialQuantity) // Extends base constructor. 
        {
            this.MaterialName = materialName; // Exeption will need created to ensure a name is entered. 
            this.UnitPrice = unitPrice; // Exception will need created to ensure unitPrice is not below 0
            this.MaterialQuantity = materialQuantity;
        }
    }

    public class Landscape : Material 
    {
        public string category = "Landscape"; // Category for reference in MaterialList[] in Material Class
        private double totalEstimatedLandscape;

        public double TotalEstimatedLandscape
        {
            get { return totalEstimatedLandscape; }
            set { totalEstimatedLandscape = value; }
        }
        public double CalculatePlumbingTotal()
        {
            double total = 0;
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    total += MaterialList[x].UnitPrice;
                }
            }
            this.totalEstimatedLandscape = total;
            return total;
        }
        public void ClearLandscapeList()
        {
            for (int x = 0; x < this.MaterialList.Length; ++x)
            {
                if (this.MaterialList[x].Category == this.category)
                {
                    this.MaterialList[x].MaterialName = "";
                    this.MaterialList[x].UnitPrice = 0.0;
                    this.MaterialList[x].MaterialQuantity = 0;
                }
            }
        }
        public Landscape() // default constructor. 
        {
            this.MaterialName = "Plumbing Material";
            this.UnitPrice = 0.0;
            this.MaterialQuantity = 1;
            this.category = "Plumbing";
        }
        public Landscape(string materialName, double unitPrice, int materialQuantity) : base(materialName, unitPrice, materialQuantity) // Extends base constructor. 
        {
            this.MaterialName = materialName; // Exeption will need created to ensure a name is entered. 
            this.UnitPrice = unitPrice; // Exception will need created to ensure unitPrice is not below 0
            this.MaterialQuantity = materialQuantity;
        }
    }


}
