public class FeatureCollection
{
    // Problem 5, step 1 - ADD YOUR CODE HERE
    // Models the top-level "features" array from the USGS GeoJSON response.
    // JsonSerializer will map the JSON key "features" to this property
    // (case-insensitive matching is already enabled in EarthquakeDailySummary).
    public Feature[] Features { get; set; }
}

// Represents one earthquake entry ("feature") in the GeoJSON "features" array.
// Created as part of Problem 5 to support deserializing the USGS response.
public class Feature
{
    // Each feature has a "properties" object containing the earthquake's details
    // (place, magnitude, time, etc. - we only need place and mag for this assignment)
    public FeatureProperties Properties { get; set; }
}

// Models just the two fields we need from each earthquake's "properties" object.
// Created as part of Problem 5 to support deserializing the USGS response.
public class FeatureProperties
{
    public string Place { get; set; } // the 'place' attribute, e.g. "10km NW of Somewhere, CA"
    public double Mag { get; set; }   // the 'mag' attribute, e.g. 1.5
}