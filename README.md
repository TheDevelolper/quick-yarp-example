# quick-yarp-example

A .NET Aspire sample demonstrating YARP (Yet Another Reverse Proxy) with round-robin load balancing across two weather API backends.

## Projects

- **weather1** — returns "Freezing" only (tests that traffic reaches this instance)
- **weather2** — returns the full set including "Sweltering" (tests that traffic reaches this instance too)
- **yarp** — reverse proxy using round-robin to distribute requests between weather1 and weather2

Since one backend only ever returns "Freezing" while the other returns all summaries, you can verify round-robin distribution by hitting the proxy multiple times and observing the changing summaries.

## Getting Started

1. Start the Aspire app (launches all three projects + dashboard):

   ```shell
   dotnet run --project aspire
   ```

2. Open `yarp.http` in your editor and send the requests to test the proxy endpoints.
