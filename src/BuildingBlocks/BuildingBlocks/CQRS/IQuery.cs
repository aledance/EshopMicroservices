using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface IQuery<out TResponse> : IRequest<TResponse> // IRequest es una interfaz de MediatR que representa una solicitud que devuelve un resultado.
     where TResponse : notnull // notnull es una restricción que indica que el tipo TResponse no puede ser un tipo de referencia nulo. Esto significa que TResponse debe ser un tipo de valor o un tipo de referencia que no permita valores nulos.
    {
       
    }
}
