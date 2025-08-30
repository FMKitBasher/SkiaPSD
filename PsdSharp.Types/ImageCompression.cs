namespace PsdSharp.Types;

public enum ImageCompression
{
    /// <summary>
    /// Raw data
    /// </summary>
    Raw = 0,
    /// <summary>
    /// RLE compressed
    /// </summary>
    Rle = 1,
    
    // <summary>
    // ZIP without prediction.
    // <remarks>
    // This is currently not supported since it is ot documented.
    // Loading will result in an image where all channels are set to zero.
    // </remarks>
    // </summary>
    // Zip = 2,
    
    // <summary>
    // ZIP with prediction.
    // <remarks>
    // This is currently not supported since it is ot documented. 
    // Loading will result in an image where all channels are set to zero.
    // </remarks>
    // </summary>
    // ZipPrediction = 3
}