using DesignBusinessCore.BusinessCore;

namespace DesignBusinessCore.Implementation;

// implement business core to handle this usecase 
internal sealed class PingHandler : IPingHandler
{
    public PingOutput Handle(PingCommand command)
    {
        return new PingOutput() { Success = true };
    }
}
