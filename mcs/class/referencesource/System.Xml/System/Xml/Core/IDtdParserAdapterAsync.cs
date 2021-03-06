
using System;
using System.Text;
#if !SILVERLIGHT
using System.Xml.Schema;
#endif

#if SILVERLIGHT
using BufferBuilder=System.Xml.BufferBuilder;
#else
using BufferBuilder=System.Text.StringBuilder;
#endif

using System.Threading.Tasks;

namespace System.Xml {

    internal partial interface IDtdParserAdapter {

        Task< int > ReadDataAsync();

        Task< int > ParseNumericCharRefAsync( BufferBuilder internalSubsetBuilder );
        Task< int > ParseNamedCharRefAsync( bool expand, BufferBuilder internalSubsetBuilder );
        Task ParsePIAsync( BufferBuilder sb );
        Task ParseCommentAsync( BufferBuilder sb );

        Task< Tuple<int,bool> > PushEntityAsync( IDtdEntityInfo entity);

        Task< bool > PushExternalSubsetAsync( string systemId, string publicId );

    }

}
