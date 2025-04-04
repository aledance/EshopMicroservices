using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks.CQRS;
using MediatR;

public interface ICommand : ICommand<Unit> // Unit es un tipo de valor que representa una ausencia de valor o un resultado vacío. Se utiliza comúnmente en programación funcional y en bibliotecas como MediatR para indicar que no se espera un resultado significativo de una operación.
{
}

namespace BuildingBlocks.CQRS
{
    public interface ICommand<out TResponse> : IRequest // IRequest es una interfaz de MediatR que representa una solicitud que no devuelve un resultado.
    {
    }
}
