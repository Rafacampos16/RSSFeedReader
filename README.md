# RSSFeedReader Project Description

RSSFeedReader is a minimal MVP application designed to demonstrate the core capability of managing RSS/Atom feed subscriptions.

## What it does

- Lets a user add a feed subscription by entering a feed URL.
- Displays the current list of subscriptions in the UI.
- Stores subscriptions in memory for the current session only.
- Uses a simple backend API and a lightweight frontend to show the end-to-end flow.

## Why it exists

The project is intended as a proof of concept for subscription management, focusing on rapid delivery and a small, maintainable architecture.
Feed fetching, parsing, validation, and persistence are intentionally deferred to later phases.

## Architecture

- **Backend:** ASP.NET Core Web API at `http://localhost:5151`
- **Frontend:** Static UI served from `http://localhost:5213`
- **Storage:** In-memory list of subscriptions
- **API contract:**
  - `GET /api/subscriptions` returns the current subscription list
  - `POST /api/subscriptions` adds a new subscription URL

## MVP scope

- Add a subscription URL
- Show the subscription list
- Keep the UI simple and functional

## Future work

The architecture supports later extension to:

- fetch and parse RSS/Atom feeds
- persist subscriptions across sessions
- support subscription removal and ordering
- convert the frontend to a full Blazor WebAssembly experience
