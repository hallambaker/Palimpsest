using Goedel.Cryptography.Dare;

namespace Mplace2.Gui;

public class CachedCatalog<T> : VDareCatalog<T> where T : JsonObject, new() {

    CatalogCache CatalogCache;

    /// <summary>Constructor returning a new instance bound to cache 
    /// <paramref name="catalogCache"/> reading and writing to <paramref name="stream"/>.</summary>
    /// <param name="catalogCache"></param>
    /// <param name="stream"></param>
    public CachedCatalog(
            CatalogCache catalogCache,
            VDareStream stream) : base(stream) {
        CatalogCache = catalogCache;


        if (stream.Length == 0) {
            stream.WriteTypeIdentifier(DareConstants.TypeIdentifierDareSequence);
            WriteInitial();
            }
        else {
            ReadInitial();
            }

        //throw new NYI();
        ////Initialize();

        }

    /// <inheritdoc/>
    public override VDareEntryIndex<T> Add(T item) {
        return base.Add(item);
        }

    /// <inheritdoc/>
    public override VDareEntryIndex<T> Update(T item) {
        return base.Update(item);
        }

    /// <inheritdoc/>
    public override VDareEntryIndex<T> Delete(string id) {
        return base.Delete(id);
        }

    protected override ContentMeta GetContentMeta() => new ContentMeta() {
        UniqueId = Udf.Nonce(),
        Created = DateTime.UtcNow,
        MessageType = ContentType
        };

    }


