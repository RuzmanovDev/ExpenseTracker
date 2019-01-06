<template>
  <div id="app">
    <nav>
      <ul class="navigation-list">
        <li>
          <router-link :to="{ name: 'home'}">Home</router-link>
        </li>
        <li>
          <router-link :to="{ name: 'expense-list'}">Expense list</router-link>
        </li>
        <li>
          <router-link :to="{ name: 'register'}">Register</router-link>
        </li>
        <li>
          <router-link :to="{ name: 'login'}">Login</router-link>
        </li>
        <li>
          <a href="#" v-on:click="logout()">Logout</a>
        </li>
      </ul>
    </nav>
    <router-view/>
  </div>
</template>

<script>
import authService from "./services/auth-service.js";
export default {
  name: "app",
  methods: {
    logout() {
      authService.logout();
    }
  }
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

.navigation-list {
  list-style-type: none;
}
.navigation-list li {
  display: inline-block;
  margin-right: 10px;
}
</style>
