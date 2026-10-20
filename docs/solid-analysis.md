# SOLID Principle Analysis — EduHub

## Overview

This document describes potential SOLID principle violations in the EduHub club management system. The analysis is preliminary and must be checked against the original `ClubManager` implementation when the starter code becomes available.

## 1. Single Responsibility Principle (SRP)

**Principle:** A class should have one primary responsibility.

**Potential violation:** If `ClubManager` creates clubs, registers members, sends notifications, and generates reports, it has multiple reasons to change.

**Refactoring idea:** Separate club management, notification, and reporting responsibilities into dedicated classes.

## 2. Open/Closed Principle (OCP)

**Principle:** Software entities should be open for extension but closed for modification.

**Potential violation:** If `ClubManager` uses conditional statements to handle each notification type, adding a new notification type requires modifying existing logic.

**Refactoring idea:** Introduce an interface such as `INotificationService` and add implementations for different notification methods.

## 3. Liskov Substitution Principle (LSP)

**Principle:** Objects of a subtype should be usable wherever their base type is expected without breaking correct behavior.

**Potential violation:** If a derived class overrides a method but changes its expected behavior or throws an unexpected exception, it may violate LSP.

**Refactoring idea:** Define clear contracts and ensure implementations preserve the behavior expected by their interfaces or base classes.

## 4. Interface Segregation Principle (ISP)

**Principle:** Clients should not depend on methods they do not use.

**Potential violation:** A large interface that combines notifications, reporting, and persistence forces implementations to provide unrelated methods.

**Refactoring idea:** Split the interface into smaller interfaces, such as `INotificationService`, `IReportService`, and `IClubRepository`.

## 5. Dependency Inversion Principle (DIP)

**Principle:** High-level modules should depend on abstractions rather than concrete implementations.

**Potential violation:** If `ClubManager` directly constructs a database repository or email sender, it is tightly coupled to those concrete classes.

**Refactoring idea:** Inject interfaces through the constructor and provide concrete implementations from outside the manager.

## Conclusion

These are potential design issues to investigate. The final analysis must identify at least four violations that are demonstrably present in the actual `ClubManager` starter code.
