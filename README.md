dotnet build
dotnet run

List all polls:
Endpoint: /poll
Method: GET

Get a poll:
Endpoint: /poll/{id}
Method: GET
Parameters: id

Vote
Endpoint: /poll/{id}/vote/{option}
Method: GET (!)
Parameters: id (id of the poll to vote in) option (id of the option to vote for)

Create a new poll:
Endpoint: /poll/add
Method: POST
Body:
{
    "title": "Test question",
    "options": [
        { "title": "Option1" },
        { "title": "Option2" }
    ]
}