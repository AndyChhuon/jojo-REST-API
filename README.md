# .NET/C# REST API for Jojo Web App

This is a simple example of the `REST API` that will be used for [Jojo Web App Project](https://github.com/AndyChhuon/jojo-soen341project2023).

The application will be using `MongoDB` to store its data. Currently, the data is only stored in memory.
<br />

# REST API

The REST API to the example app is described below.

## Get list of Applicants

### Request

`GET /api/JobApplicantsAPI`

    curl -X 'GET' \
        'https://localhost:7177/api/JobApplicantsAPI' \
        -H 'accept: text/plain'

### Response Headers

    content-type: application/json; charset=utf-8
    date: Wed,01 Feb 2023 02:49:02 GMT
    server: Kestrel

### Response Body

    [
        {
            "id": "bb6836c5-2c21-4897-abf2-7fed61002c25",
            "name": "Joe",
            "createdDate": "2023-02-01T02:44:28.6375593+00:00"
        },
        {
            "id": "a570cc02-ee97-4855-80f0-0aa54e549908",
            "name": "Jack",
            "createdDate": "2023-02-01T02:44:28.6376095+00:00"
        },
        {
            "id": "a25edee7-cb2e-4911-bfbe-e95b559ccee8",
            "name": "John",
            "createdDate": "2023-02-01T02:44:28.6376098+00:00"
        }
    ]

## Create a new applicant

### Request

`POST /api/JobApplicantsAPI`

    curl -X 'POST' \
        'https://localhost:7177/api/JobApplicantsAPI' \
        -H 'accept: text/plain' \
        -H 'Content-Type: application/json' \
        -d '{
        "name": "andy"
    }'

### Response Headers

    content-type: application/json; charset=utf-8
    date: Wed,01 Feb 2023 02:55:49 GMT
    location: https://localhost:7177/api/JobApplicantsAPI/f02d75ee-6624-4af3-9a48-6afa9d3733f5
    server: Kestrel

### Response Body

    {
        "id": "f02d75ee-6624-4af3-9a48-6afa9d3733f5",
        "name": "andy",
        "createdDate": "2023-02-01T02:55:50.5756991+00:00"
    }

## Get an applicant by ID

### Request

`GET /api/JobApplicantsAPI/{id}`

    curl -X 'GET' \
        'https://localhost:7177/api/JobApplicantsAPI/f02d75ee-6624-4af3-9a48-6afa9d3733f5' \
        -H 'accept: text/plain'

### Response Headers

    content-type: application/json; charset=utf-8
    date: Wed,01 Feb 2023 03:00:10 GMT
    server: Kestrel

### Response Body

    {
        "id": "f02d75ee-6624-4af3-9a48-6afa9d3733f5",
        "name": "andy",
        "createdDate": "2023-02-01T02:55:50.5756991+00:00"
    }

## Get a non-existent applicant

### Request

`GET /api/JobApplicantsAPI/{id}`

    curl -X 'GET' \
        'https://localhost:7177/api/JobApplicantsAPI/f02d75ee-6624-4af3-9a48-6afa9d3733f4' \
        -H 'accept: text/plain'

### Response Headers

    content-type: application/problem+json; charset=utf-8
    date: Wed,01 Feb 2023 03:02:13 GMT
    server: Kestrel

### Response Body

    {
        "type": "https://tools.ietf.org/html/rfc7231#section-6.5.4",
        "title": "Not Found",
        "status": 404,
        "traceId": "00-21dfda22f74957e05afb25d3eaea0e76-1c94dd2eaec2932a-00"
    }

## Update an Applicant by ID

### Request

`PUT /api/JobApplicantsAPI/{id}`

    curl -X 'PUT' \
        'https://localhost:7177/api/JobApplicantsAPI/f02d75ee-6624-4af3-9a48-6afa9d3733f5' \
        -H 'accept: text/plain' \
        -H 'Content-Type: application/json' \
        -d '{
        "name": "jack"
    }'

### Response Headers

    date: Wed,01 Feb 2023 03:05:05 GMT
    server: Kestrel

### Response Body

    204 No Content

## Delete an Applicant by ID

### Request

`DELETE /api/JobApplicantsAPI/{id}`

    curl -X 'DELETE' \
        'https://localhost:7177/api/JobApplicantsAPI/f02d75ee-6624-4af3-9a48-6afa9d3733f5' \
        -H 'accept: text/plain'

### Response Headers

    date: Wed,01 Feb 2023 03:11:26 GMT
    server: Kestrel

### Response Body

    204 No Content
