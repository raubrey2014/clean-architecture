## Code/examples from Clean Architecture by Robert Martin

### Design Principles

SRP - **A class should have only one reason to change**. Or, a class should only have one stakeholder/actor.

Common smell - a class contains business rules AND methods to store in persistence. If your datastore were to change, the class that contains the business rules would change dramatically, but it would also change due to changes in the business rules.

This principle will reappear at all levels of architecture - functions & classes, components (Common Closure Principle), architecture (Axis of Change).
