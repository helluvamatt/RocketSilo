# RocketSilo

A net6 wrapper for [SpaceTraders.io](https://spacetraders.io)

```c#
//use with an existing token
Client client = RocketSilo.Api.Client.CreateClient("<your-token-here>");

//create a new user and get token
string token = RocketSilo.Api.Client.CreateNewUser("<unique-username>");
//then get a client
Client client = RocketSilo.Api.Client.CreateClient(token);
```