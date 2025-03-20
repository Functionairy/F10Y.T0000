using System;


namespace F10Y.T0000
{
    /// <summary>
    /// Marks an attribute as being a marker attribute.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Marker attributes are useful when surveying assemblies and code.
    /// </para>
    /// <para>
    /// For example: you could create a values-marker attribute that, when applied to a type, informs a process surveying the code that all properties of the type are should be interpretted as values.
    /// This marker attribute-marker attribute is used to mark marker attributes as marker attributes, so that they are interpretted as marker attributes in a code survey.
    /// </para>
    /// <para>
    /// Marker attributes (attributes marked with this marker attribute) can then be accumulated in catalogue of marker attributes.
    /// </para>
    /// </remarks>
    [MarkerAttributeMarker] // The marker attribute marker attribute is itself a marker attribute.
    [AttributeUsage(
        AttributeTargets.Class, // Attributes can only be classes.
        AllowMultiple = false, // An attribute is either a marker attribute, or it is not. No need for multiple attributes.
        Inherited = false // While attributes CAN be inherited, generally they are not. So force users to re-mark any inherited attribute types.
    )]
    public class MarkerAttributeMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that an attribute type is *not* a marker attribute, even if it is marked with the marker attribute-marker attribute.
        /// This is useful for marking types that end up canonical marker attribute code file locations, but are not actually marker attributes.
        /// </summary>
        public bool Is_MarkerAttribute { get; }


        public MarkerAttributeMarkerAttribute(
            bool is_MarkerAttribute = true)
        {
            this.Is_MarkerAttribute = is_MarkerAttribute;
        }
    }
}
