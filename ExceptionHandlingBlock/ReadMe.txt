Exception Handling Block
App => Exception Handling Block (do something) return to => App

What can you do with exceptions?
1. Wrap - catching exception and putting in another exception
2. Replace - throw new exception
3. Log and Rethrow - logger

- if you can't add value to catching exception than don't use it! - you can let it bubble up

What does Microsoft Enterpise Exception Handling Block provide?
- get rid of try/catch
- define policies for handling exceptions
- make them configurable without recomplilation
- custom policies

When to use The Block?
- common set of ways of dealing with exceptions
- exception handling framework or rules
- logging exceptions


OVERVIEW
1. Configuration of exception block - using EntLibConfig.exe - writes config to app.config file
2. Code => Wrapping exception => Config manager
3. WCF (Client/Server) sample
5. Custom Exceptions => ScrubberHandler.cs
