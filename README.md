# NGINX Mirror Docker Example

## Usage

1. Start the proxy and the two backend APIs

```sh
docker compose -f compose.yaml pull
docker compose -f compose.yaml up --detach --build
```

2. Make a request to the proxy

```sh
curl localhost:8080
```

3. Review the Docker logs and see the request hit both backend APIs, but only the response from
   Backend #1 is returned and the response from Backend #2 is discarded.
