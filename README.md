# quick-yarp-example

A .NET Aspire sample demonstrating YARP (Yet Another Reverse Proxy) with round-robin load balancing across 10 identical API instances.

## Projects

- **example-api** — a simple API that returns its instance ID (injected via `INSTANCE_ID` env var) at the `/data/` endpoint
- **yarp** — reverse proxy using round-robin to distribute requests across all 10 API instances

The Aspire orchestration launches 10 instances of `example-api` on ports 7700-7709, each with a unique `INSTANCE_ID` (0-9). Hitting the proxy's `/data/` endpoint returns a different instance ID on each request, confirming round-robin distribution.

## Getting Started

1. Start the Aspire app (launches all projects + dashboard):

   ```shell
   dotnet run --project aspire
   ```

2. Open `yarp.http` in your editor and send the requests to test the proxy endpoints.
