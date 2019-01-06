<template>
  <div>
    <h1>List of expenses</h1>
    <ul id="example-2">
      <li v-for="(expense, index) in listExpense" :key="index">
        Title: {{ expense.title }}
        Amount: {{expense.amount}}
      </li>
    </ul>

    <div id="createExpenseForm">
      <div>
        Expense Title
        <input
          type="text"
          name="expense-title"
          id="expenseTitle"
          v-model="expenseTitle"
        >
      </div>
      <div>
        Expense Amount
        <input
          type="text"
          name="expense-amount"
          id="expenseAmount"
          v-model="expenseAmount"
        >
      </div>
      <button v-on:click="addExpense()">Click me</button>
    </div>
  </div>
</template>


<script>
export default {
  name: "ExpenseList",
  created() {
    this.$store.dispatch("getExpenses");
  },
  data() {
    return {
      expenseTitle: "default",
      expenseAmount: 0
    };
  },
  computed: {
    listExpense() {
      return this.$store.state.expenses;
    }
  },
  methods: {
    addExpense() {
      this.$store.commit("addExpense", {
        title: this.expenseTitle,
        amount: this.expenseAmount
      });
    }
  }
};
</script>

<style>
</style>