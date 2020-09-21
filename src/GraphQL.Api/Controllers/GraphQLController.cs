using GraphQL.Api.Requests;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GraphQL.Api.Controllers
{
    [Route("[controller]")]
    public class GraphQLController : ControllerBase
    {
        private readonly ISchema _schema;
        private readonly IDocumentWriter _documentWriter;
        
        public GraphQLController(ISchema schema, IDocumentWriter documentWriter)
        {   
            _schema = schema;
            _documentWriter = documentWriter;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLRequest request)
        {
            var inputs = request.Variables.ToInputs();
            var json = await _schema.ExecuteAsync(_documentWriter, options =>
            {
                options.Query = request.Query;
                options.OperationName = request.OperationName;
                options.Inputs = inputs;
            });

            return Ok(json);
        }
    }
}