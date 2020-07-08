# ASP.NET-API

to use url:

GET ALL :

    https://{host}:{port}/api/suppliers/

GET ID :

    https://{host}:{port}/api/suppliers/{id}

POST :

    https://{host}:{port}/api/suppliers/

    raw body:
    {
        "Name": "asd"
    }

PUT :

    https://{host}:{port}/api/suppliers/{id}

    raw body:
    {
        "Id": {id},
        "Name": "{nama}"
    }

DELETE : 

    https://{host}:{port}/api/suppliers/{id}