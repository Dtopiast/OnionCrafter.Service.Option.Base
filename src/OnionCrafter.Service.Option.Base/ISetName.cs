namespace OnionCrafter.Service.Option.Base
{
    /// <summary>
    /// Interface for addition of property to set name.
    /// </summary>
    public interface ISetName
    {
        /// <summary>
        /// Sets the name of the class.
        /// </summary>
        /// <value>
        /// The name of the class.
        /// </value>
        public string? SetName { get; set; }
    }
}