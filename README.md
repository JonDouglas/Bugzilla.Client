# Bugzilla.Client
Client for use of bugzilla 5.0+ REST api

## Getting Started

Bugzilla has many ways to authenticate a user.

### Creating an API key in Bugzilla

1. Go to your "User Preferences":

![userpref](https://content.screencast.com/users/JDouglas2529/folders/Snagit/media/14c8436f-f674-4ddf-b53b-a4b29d8dbf93/01.11.2017-15.16.png)

2. Go to "API Keys":

![apikeys](https://content.screencast.com/users/JDouglas2529/folders/Snagit/media/ade648ef-e2bc-4f4a-9405-306605d9edb1/01.11.2017-15.17.png)

3. You can then generate an API key for use in the Bugzilla client

![generatekey](https://content.screencast.com/users/JDouglas2529/folders/Snagit/media/d58dbcb4-ec75-47b6-8506-389e65f3ab90/01.11.2017-15.18.png)

### Logging in via Bugzilla (NOT FULLY SUPPORTED YET)

You can also log in using your bugzilla credentials. To do this, you can use the following method to retrieve a token

`var token = await LoginAsync(string email, string password);`

Once you obtain that token, you then need to include it in every method. (This will be refactored later to a property of the client)

## Querying the API

This client currently has ~30 APIs that you can use with Bugzilla. Here is a brief overview of those APIs:

![apis](https://content.screencast.com/users/JDouglas2529/folders/Snagit/media/68a14a2e-eb8b-4ec5-a73d-02825c485797/01.11.2017-15.22.png)

To start querying away, all you need to do is `new` up a `BugzillaClient` with two arguments:

- `endpoint` - Which Bugzilla endpoint you want to use. Most bugzilla instances use the `.cgi` extension for their REST endpoint
- `apiKey` - Which you generated via the instructions above

EX: `var bugzillaClient = new BugzillaClient("https://bugzilla.xamarin.com/rest.cgi", "API_KEY");

## Known Issues

- Current `token` does not get passed into any of these methods and thus logging in via Bugzilla(aka auth #2) doesn't work.
- Create, Update, Delete methods are soon to come. They need quite a bit of documentation to get right as the objects aren't straight-forward.
- This is currently a `netstandard 1.4` library and thus you will need to at least target `netstandard 1.4` to use this library.
