<template>
  <div id="app">
    <nav>
      <ul class="navigation-list">
        <li>
          <router-link to="/">Home page</router-link>
        </li>
        <li>
          <router-link to="/expenses">Expense lis</router-link>
        </li>
      </ul>
    </nav>
    <router-view/>
  </div>
</template>

<script>
export default {
  name: "app"
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
