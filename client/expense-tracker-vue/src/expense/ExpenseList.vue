<template>
  <div>
    <h1>List of expenses</h1>
    <div>{{title}}</div>
    <div>{{description}}</div>
    <div>{{amount}}</div>
    <div>{{dateOfExpense}}</div>
    <button v-bind="Cick">Click me</button>
  </div>
</template>


<script>
export default {
  name: "ExpenseList",
  data() {
    return {
      title: "Oil change",
      amount: 20,
      description: "The oil was change with w5",
      dateOfExpense: "2019-01-01"
    };
  }
};
</script>

<style>
</style>