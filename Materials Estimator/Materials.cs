using System;

namespace Materials_Estimator
{
    public class Material
    {
        String[] materialList; // List of all materials
        double[] unitPrice; // unitPrice of all materials
        protected String[] category = ["Masonry", "Plumbing", "Electric", "HVAC", "Insulation", "Flooring", "Landscape"]; // Can only be accessed by a class derived from Material
        int orderQuantity;
        double estimatedCost;
    }
    public class Masonry : Material
    {
        String[] masonryList; // List of all Masonry Materials
        double[] masonryUnitPrice; // List of all Masory Material Prices
        double totalEstimatedMasonry;
    }
    public class Plumbing : Material
    {
        String[] plumbingList; // List of all Plumbing Materials
        double[] plumbingUnitPrice; // List of all Plumbing Material Prices
        double totalEstimatedMasonry;
    }

    public class Electric : Material
    {
        String[] electricList; // List of all Electric Materials
        double[] electricUnitPrice; // List of all Electric Material Prices
        double totalEstimatedElectric;
    }

    public class HVAC : Material
    {
        String[] hvacList; // List of all HVAC Materials
        double[] hvacUnitPrice; // List of all HVAC Material Prices
        double totalEstimatedHvac;
    }

    public class Insulation : Material
    {
        String[] insulationList; // List of all Insulation Materials
        double[] insulationUnitPrice; // List of all Insulation Material Prices
        double totalEstimatedInsulation;
    }

    public class Flooring : Material
    {
        String[] flooringList; // List of all Flooring Materials
        double[] flooringUnitPrice; // List of all Insulation Material Prices
        double totalEstimatedFlooring;
    }

    public class Landscape : Material 
    {
        String[] landscapeList; // List of all Landscape Materials
        double[] landscapeUnitPrice; // List of all Landscape Material Prices
        double totalEstimatedLandscape;
    }


}
