# Upgrade Options — CleanApi

Assessment: 4 projects, all on net8.0, upgrading to net10.0, 4 package upgrades needed, low risk

## Strategy

### Upgrade Strategy
Small solution (4 projects) with mechanical TFM bump from modern .NET 8 to modern .NET 10, no high-risk migrations detected.

| Value | Description |
|-------|-------------|
| **All-at-Once** (selected) | Upgrade all projects simultaneously in a single atomic pass — fastest approach for small solutions with no complex dependencies |
| Top-Down | Upgrade entry-point applications first with temporary multi-targeting on libraries — better for large solutions or when CI must stay green |
