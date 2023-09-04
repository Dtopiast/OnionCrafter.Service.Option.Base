namespace OnionCrafter.Service.Option.Base
{
    /// <summary>
    /// Interface for service options.
    /// </summary>
    public interface IServiceOptions : IBaseServiceOptions, ISetName
    {
        /// <summary>
        /// Gets or sets the service name.
        /// </summary>
        public new string? SetName { get; set; }
    }
}