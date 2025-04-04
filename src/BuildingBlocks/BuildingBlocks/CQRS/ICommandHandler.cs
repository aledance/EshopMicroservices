using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BuildingBlocks.CQRS
{
    // ICommand es una interfaz que representa un comando en el patrón CQRS (Command Query Responsibility Segregation).
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, Unit>
        // IRequestHandler es una interfaz de MediatR que define un manejador para una solicitud (request).          
        where TCommand : IRequest<Unit>, ICommand
    {
    }

    // La interfaz 'ICommandHandler' define un manejador de comandos que devuelve un resultado de tipo 'TResponse'.
    // Implementa 'IRequestHandler' de MediatR, donde 'TCommand' es el tipo de comando y 'TResponse' es el tipo de resultado.
    // 'TResponse' debe ser un tipo no nulo.
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : IRequest<TResponse>, ICommand<TResponse>
        where TResponse : notnull
    {
    }
}
