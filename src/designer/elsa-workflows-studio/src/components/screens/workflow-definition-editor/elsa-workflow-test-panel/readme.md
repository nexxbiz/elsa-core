# elsa-workflow-test-panel



<!-- Auto Generated Below -->


## Properties

| Property                 | Attribute                   | Description | Type                 | Default     |
| ------------------------ | --------------------------- | ----------- | -------------------- | ----------- |
| `culture`                | `culture`                   |             | `string`             | `undefined` |
| `serverUrl`              | `server-url`                |             | `string`             | `undefined` |
| `workflowDefinition`     | --                          |             | `WorkflowDefinition` | `undefined` |
| `workflowTestActivityId` | `workflow-test-activity-id` |             | `string`             | `undefined` |


## Dependencies

### Used by

 - [elsa-workflow-definition-editor-screen](../elsa-workflow-definition-editor-screen)

### Depends on

- context-consumer

### Graph
```mermaid
graph TD;
  elsa-workflow-test-panel --> context-consumer
  elsa-workflow-definition-editor-screen --> elsa-workflow-test-panel
  style elsa-workflow-test-panel fill:#f9f,stroke:#333,stroke-width:4px
```

----------------------------------------------

*Built with [StencilJS](https://stenciljs.com/)*
