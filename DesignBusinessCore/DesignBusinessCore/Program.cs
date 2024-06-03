using DesignBusinessCore.BusinessCore;
using DesignBusinessCore.Implementation;

// on web service (nice syntax for encapsulation concrete class to interface base)
//services.AddScope<IPingHandler, PingHandler>();

// manual used, new by interface type
IPingHandler ping = new PingHandler();
var success = ping.Handle(new PingCommand() { Message = "ping all green" });
