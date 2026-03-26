# ADR 0000: Use Architecture Decision Records

**Status:** Accepted

**Date:** 2026-03-26

## Context

As the project grows, we need to capture important architectural and research decisions. Without documentation, decisions become tribal knowledge, rationale is forgotten, and future contributors (including future‑us) waste time rediscovering why things are the way they are.

We want a lightweight, versioned, and human‑readable way to record decisions.

## Decision

We will use **Architecture Decision Records (ADRs)** following the format defined in this document. ADRs are immutable once accepted; changes to a decision are recorded by creating a new ADR that supersedes the old one.

- **Location:** ADRs are stored in `docs/adr/`.
- **Naming:** Each ADR is a Markdown file named `NNNN-title.md` where `NNNN` is a 4‑digit number (e.g., `0000`, `0001`) and `title` is a short hyphenated description.
- **Statuses:** Each ADR has a status field. The allowed statuses are:
  - **Proposed** – The decision is under consideration but not yet final.
  - **Accepted** – The decision has been agreed upon and is in effect.
  - **Deprecated** – The decision was accepted but is no longer recommended (e.g., due to new information). It remains in the record for historical context.
  - **Superseded** – The decision has been replaced by a newer ADR (which will be referenced with a `Supersedes` section).
- **Content:** Every ADR includes at least:
  - **Title** – concise and descriptive.
  - **Status** – one of the above.
  - **Date** – when the decision was made (or the ADR was finalised).
  - **Context** – what prompted the decision, including constraints, goals, and relevant background.
  - **Decision** – what we decided and why.
  - **Consequences** – what becomes easier or harder as a result.
  - **Alternatives Considered** – other options we considered and why they were rejected (optional but encouraged).
- **Process:** A new ADR is created when a non‑trivial decision is made. It is committed in the same branch that implements the decision, and merged with that code. Once merged, it should not be edited; if the decision later changes, a new ADR is created that references the old one (using a `Supersedes` section).

## Consequences

- We will have a clear, versioned history of architectural decisions.
- Onboarding new contributors becomes easier because they can read the ADRs to understand why the code is structured as it is.
- Writing an ADR forces us to think through trade‑offs before coding, leading to more deliberate choices.
- There is a small overhead in writing ADRs, but it is justified by the long‑term maintainability gains.

## Alternatives Considered

- **No formal documentation** – Rejected because it leads to knowledge loss and makes the project harder to understand.
- **Wiki or external document** – Rejected because it’s not versioned with the code; decisions can drift.
- **Long‑form design documents** – Rejected because they are often too heavy to maintain and update; ADRs are smaller, focused, and easier to keep current.
