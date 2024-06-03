using DesignBusinessCore.BusinessCore;
using DesignBusinessCore.Implementation;

// on web service
//services.AddScope<IPingHandler, PingHandler>();

// manual used
IPingHandler ping = new PingHandler();
var success = ping.Handle(new PingCommand() { Message = "ping all green" });
