import React, { Component } from "react";
import PropTypes from "prop-types";
import { connect } from "react-redux";
import { fetchPresidents } from "../store/actions/actions";
import styles from "./Presidents.module.css";
//
import President from "./President";
class PresidentsContainer extends Component {
  componentDidMount() {
    this.props.fetchPresidents();
  }
  renderPresidents = (president, key) => {
    return <President president={president} key={key} />;
  };
  render() {
    const { presidents } = this.props;
    const presidentsList = presidents
      ? presidents.map(this.renderPresidents)
      : "Loading";
    return (
      <div className="container">
        <button onClick={()=>this.props.fetchPresidents('sortacc')}>Sort By Name Ascending</button>
        <button onClick={()=>this.props.fetchPresidents('sortdes')}>Sort By Name Descending</button>
        <h2>Presidents of the United States</h2>
        {presidentsList}
      </div>
    );
  }
}

PresidentsContainer.propTypes = {
  fetchPresidents: PropTypes.func.isRequired,
  presidents: PropTypes.array
};
const mapStateToProps = state => ({
  presidents: state.presidents.items
});

export default connect(mapStateToProps, { fetchPresidents })(
  PresidentsContainer
);
