# Api Defination 

## Login 

```json
POST {{host}}/api/v1/auth/login
```

### Login Request 
```json
{
    "email": "something@example.com",
    "password": "nweasdfb"
}
```

```
200 OK 
```

### Login responses 
```json

{
  "id": "becdc352-3efd-43fb-b4d5-b85a0d56c5d5",
  "firstName": "John",
  "lastName": "Doe",
  "email": "John@example.com",
  "token": "eyJ...GAhBg"
}
```

## Register 

```json
POST {{host}}/api/v1/auth/login
```

### Register Request 
```json
{
    "firstName": "John",
    "lastName": "Doe",
    "email": "John@example.com",
    "password": "johnnyBoi"
}
```

```
200 OK 
```

### Register responses 
```json

{
  "id": "becdc352-3efd-43fb-b4d5-b85a0d56c5d5",
  "firstName": "John",
  "lastName": "Doe",
  "email": "John@example.com",
  "token": "eyJ...GAhBg"
}
```


