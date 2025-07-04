using System;
using System.Threading;
using System.Threading.Tasks;

namespace Axon;

public record NotificationHandlerExecutor(object HandlerInstance, Func<INotification, CancellationToken, Task> HandlerCallback);